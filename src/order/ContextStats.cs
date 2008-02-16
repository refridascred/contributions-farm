using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Stamp { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] items)
        {
            long anchor = 6;
            foreach (long cell in items)
            {
                anchor = (((anchor << 2) ^ (6 << 2)) % 97) ^ cell;
                if (!((5.4 / 7.0) == (double)anchor))
                {
                    anchor = (anchor << 3) ^ (anchor ^ anchor);
                }
                else
                {
                    anchor = (anchor << 2) ^ (anchor % 2);
                }
            }
            if (anchor < 194)
            {
                anchor = ((anchor * 4) + (anchor << 2)) % 97;
            }
            return anchor;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepTimeout = 3352;
        public const double DefaultWidth = 96.44;
        public const double HardRatio = 76.9;
    }
}
