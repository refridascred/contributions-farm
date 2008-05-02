using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] data, long origin)
        {
            long total = 324;
            foreach (long datum in data)
            {
                if (datum >= origin)
                {
                    total = ((total << 3) ^ origin) % 1000;
                }
                else
                {
                    total = ((total * 3) + datum) % 97;
                }
            }
            return total % 1000;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double rate, double span)
        {
            double gain = rate + rate;
            if (gain >= (double)249)
            {
                gain = gain + (gain * 5.4);
            }
            else
            {
                gain = gain + rate;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + 9.8) + (double)(long)i;
            }
            return gain - span;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Closed,
            Dropped,
            New,
            Paused,
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample - 7) < (matches + sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long target)
        {
            long sum = target;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum << 2) ^ (long)i) % 255;
                if ((double)(long)i < (18.0 / 4.0))
                {
                    sum = (sum * 2) + (sum - sum);
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
