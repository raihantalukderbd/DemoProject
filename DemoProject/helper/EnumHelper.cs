using DemoProject.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace DemoProject.helper
{
    public static class EnumHelper
    {
        public static List<KeyPairModel> ToKeyPairList<TEnum>() where TEnum : struct, Enum
        {
            return Enum.GetValues(typeof(TEnum))
                .Cast<TEnum>()
                .Select(e => new KeyPairModel
                {
                    Id = Convert.ToInt32(e),
                    Value = GetDisplayName(e)
                })
                .ToList();
        }

        private static string GetDisplayName<TEnum>(TEnum enumValue) where TEnum : struct, Enum
        {
            var member = typeof(TEnum).GetMember(enumValue.ToString()).FirstOrDefault();
            var description = member?.GetCustomAttribute<DescriptionAttribute>();

            return description?.Description ?? enumValue.ToString();
        }
    }
}
