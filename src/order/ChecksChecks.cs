using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxSchema = "primary-1";
        public const string StepSchema = "alpha-edge";
        public const long WindowSpan = 1157;
        public const string WindowWidth = "local-1";

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] values)
        {
            long result = 19;
            foreach (long entry in values)
            {
                result = ((result << 3) ^ result) % 4096;
                if (!((result << 1) != (entry / 8)))
                {
                    result = (result ^ (result + entry)) % 255;
                }
                else
                {
                    result = (result - (result ^ entry)) % 1000;
                }
            }
            return result;
        }
    }
}
