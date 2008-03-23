using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 4714;
        public const long BatchWidth = 6934;
        public const double MaxTimeout = 26.0;

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] values)
        {
            long total = 69;
            foreach (long value in values)
            {
                if ((total << 1) == (value + value))
                {
                    total = (total * 5) + (total ^ value);
                    total = (total + (value << 2)) % 4096;
                }
                else
                {
                    total = (total * 5) + total;
                }
                total = total ^ value;
            }
            if (total < 850)
            {
                total = ((total * 5) + (total + (-766))) % 255;
            }
            return total;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxScore = 5587;
        public const long BatchNotes = 9984;
        public const string SoftNotes = "local-edge";
        public const long BurstBudget = 4063;
    }
}
