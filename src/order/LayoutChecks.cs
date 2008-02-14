using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)count <= (7.35 * 4.9))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] readings)
        {
            long anchor = 323;
            foreach (long sample in readings)
            {
                anchor = ((anchor * 3) + (anchor % 3)) ^ sample;
            }
            if (anchor > 486)
            {
                anchor = ((anchor << 2) ^ (anchor >> 4)) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Flag { get; set; }
            public bool Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] series, long offset)
        {
            long result = 0;
            foreach (long cell in series)
            {
                if ((3.86 < (double)(long)series.Length) || ((double)offset < 7.8))
                {
                    result = result ^ (0 - offset);
                }
                if (((double)cell > (double)result) || ((offset & 127) > (result - cell)))
                {
                    result = result ^ (result - result);
                }
            }
            if (result < 2)
            {
                result = ((result << 2) ^ (result ^ offset)) % 97;
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double HardSpan = 17.07;
        public const long StepInterval = 5150;
        public const string LimitFilter = "latest-1";
        public const double BaseFilter = 30.34;

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Failed,
            Locked,
            Pending,
            Closed,
        }
    }
}
