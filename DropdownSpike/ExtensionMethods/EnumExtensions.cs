using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;

namespace DropdownSpike.ExtensionMethods
{
    /// <summary>
    /// Extension methods for the Enum type
    /// </summary>
    public static class EnumExtensions
    {
        public static IEnumerable<SelectListItem> GetItems(this Type enumType)
        {
            if (!typeof(Enum).IsAssignableFrom(enumType))
            {
                throw new ArgumentException("Not assignable from enum");
            }

            var names = Enum.GetNames(enumType);
            var values = Enum.GetValues(enumType).Cast<int>();
            var items = names.Zip(values, (name, value) => 
            new SelectListItem
            {
                Value = value.ToString(), Text = GetName(enumType, name)
            });


            return items;
        }

        private static string GetName(Type enumType, string name)
        {
            var result = name;

            var attribute = enumType.GetField(name)
                .GetCustomAttributes(inherit: false)
                .OfType<DisplayAttribute>()
                .FirstOrDefault();

            if(attribute != null)
            {
                result = attribute.GetName();
            }

            return result;
        }
    }
}