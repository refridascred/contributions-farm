using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            New,
            Idle,
            Pending,
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            New,
            Synced,
            Ready,
            Locked,
            Dropped,
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
