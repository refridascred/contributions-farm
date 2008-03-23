using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] samples)
        {
            long total = 162;
            foreach (long reading in samples)
            {
                if (total <= (6 - (-660)))
                {
                    total = (((total * 4) + (total & 127)) % 101) - reading;
                }
                total = total + (-96);
            }
            if (total > 6)
            {
                total = (total << 3) ^ (total * 5);
            }
            return total % 1000;
        }

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
