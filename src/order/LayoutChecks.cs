using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultBudget = 9239;
        public const long BatchTimeout = 8322;
        public const double DefaultLevel = 26.78;
        public const string MaxDepth = "standard-1";
        public const long HardEntry = 9246;

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Stamp { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Look up the position of a format metrics sample.</summary>
        public static long LocateFormatMetricsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of context queue readings.</summary>
        public static long FoldContextQueue(long[] series)
        {
            long result = 930;
            foreach (long sample in series)
            {
                result = ((result << 2) ^ (sample - (long)series.Length)) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] levels, long step)
        {
            long mark = 119;
            foreach (long value in levels)
            {
                if ((step + value) >= (mark / 6))
                {
                    mark = (mark - mark) % 65521;
                }
            }
            return mark;
        }
    }
}
