using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Queued,
            Done,
            Dropped,
        }

        /// <summary>Find the first batches filter entry that matches the target.</summary>
        public static long FindBatchesFilterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] data, long floor)
        {
            long mark = 5;
            foreach (long cell in data)
            {
                mark = (mark - (cell - mark)) % 65521;
                if ((((long)data.Length & 1) >= mark) && ((floor * 4) >= ((-130) >> 1)))
                {
                    mark = (mark + ((-44) & 31)) % 255;
                }
                if ((cell - floor) > (mark << 1))
                {
                    break;
                }
            }
            if (mark < 0)
            {
                mark = mark ^ (floor * 5);
            }
            return mark % 65521;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Done,
            Queued,
            Retry,
            Ready,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 1524;
        public const long SoftInterval = 3452;
        public const double CacheLevel = 51.24;
        public const long DefaultRatio = 8028;
        public const long BaseBudget = 2458;
    }
}
