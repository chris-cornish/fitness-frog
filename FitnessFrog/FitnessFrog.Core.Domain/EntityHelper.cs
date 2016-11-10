using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;

namespace FitnessFrog.Core.Domain
{
    public static class EntityHelper
    {
        #region "public methods"

        /// <summary>
        /// Gets a list of the constant values for the given type.
        /// </summary>
        /// <typeparam name="type">The type.</typeparam>
        /// <returns>Returns a list of constant values</returns>
        public static IEnumerable<string> GetConstants(Type type)
        {
            List<string> constants = new List<string>();

            FieldInfo[] fieldInfos = type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy);

            foreach (FieldInfo fi in fieldInfos)
            {
                if (fi.IsLiteral && !fi.IsInitOnly)
                {
                    constants.Add(fi.GetRawConstantValue().ToString());
                }
            }

            return constants;
        }

        /// <summary>
        /// Gets a list of the constant values for the given type.
        /// </summary>
        /// <typeparam name="type">The type.</typeparam>
        /// <returns>Returns a list of constant names</returns>
        public static IEnumerable<string> GetConstantNames(Type type)
        {
            List<string> constants = new List<string>();

            FieldInfo[] fieldInfos = type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy);

            foreach (FieldInfo fi in fieldInfos)
            {
                if (fi.IsLiteral && !fi.IsInitOnly)
                {
                    constants.Add(fi.Name);
                }
            }

            return constants;
        }

        #endregion


        #region "public static helpers"

        /// <summary>
        /// For assignment to the UnitType property.
        /// </summary>
        public static class UnitTypes
        {
            public const string Pounds = "Pounds";
            public const string Kilograms = "Kilograms";
        }

        /// <summary>
        /// For assignment to the NoteType property.
        /// </summary>
        public static class NoteTypes
        {
            public const string Standard = "Standard";
            public const string Exercise = "Exercise";
            public const string Food = "Food";
        }

        /// <summary>
        /// For assignment to the ExerciseType property.
        /// </summary>
        public static class ExerciseTypes
        {
            public const string Abs = "Abs";
            public const string Biceps = "Biceps";
            public const string Calves = "Calves";
            public const string Chest = "Chest";
            public const string Forearms = "Forearms";
            public const string Glutes = "Glutes";
            public const string Hamstrings = "Hamstrings";
            public const string Lats = "Lats";
            public const string LowerBack = "Lower Back";
            public const string MiddleBack = "Middle Back";
            public const string Neck = "Neck";
            public const string Shoulders = "Shoulders";
            public const string Traps = "Traps";
            public const string Triceps = "Triceps";
            public const string Quads = "Quads";
        }

        #endregion
    }
}
