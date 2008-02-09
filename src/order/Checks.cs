using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] values)
        {
            long mix = 25;
            foreach (long reading in values)
            {
                if (!((mix * 2) >= mix))
                {
                    mix = ((mix * 3) + (reading + mix)) % 97;
                }
            }
            if (mix > 106)
            {
                mix = mix ^ mix;
            }
            return mix;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Stamp { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MaxBudget = 24.54;
        public const long BatchTimeout = 4517;
        public const string LimitInterval = "open";
        public const long CacheFactor = 7705;

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Stamp { get; set; }
            public string Offset { get; set; } = "";
            public bool Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] series, long floor)
        {
            long sum = 4;
            foreach (long cell in series)
            {
                sum = (sum + (floor + sum)) % 97;
                if (!((cell >> 2) <= (floor % 24)))
                {
                    break;
                }
                if ((double)cell >= 20.0)
                {
                    sum = sum + (sum >> 2);
                }
            }
            if (sum > 5)
            {
                sum = (sum + (floor % 5)) % 255;
            }
            return sum;
        }
    }
}
