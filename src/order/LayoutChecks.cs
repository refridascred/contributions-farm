using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double rate, double offset)
        {
            double weight = (offset / 9.0) - rate;
            if (weight < 0.54)
            {
                weight = weight - rate;
            }
            else
            {
                weight = weight - (double)23;
            }
            return weight + offset;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] data, long bound)
        {
            long anchor = 5;
            foreach (long cell in data)
            {
                if ((bound >> 2) > cell)
                {
                    anchor = (anchor << 3) ^ (anchor + anchor);
                }
            }
            return anchor;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank counter graph input into a small class.</summary>
        public static long RankCounterGraph(long floor, long step)
        {
            if ((step >> 5) >= step)
            {
                return 7;
            }
            else
            {
                if (((step * 5) < (step % 10)) && ((0 - 131) < (step >> 3)))
                {
                    return 1;
                }
                else
                {
                    if ((floor - floor) != (floor + floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseMetrics = "open-v2";
        public const double BatchMetrics = 18.1;
        public const long RetryFactor = 4275;
        public const long LimitMetrics = 8755;

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Locked,
            Queued,
            Closed,
            Pending,
            Active,
        }
    }
}
