using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Done,
            Ready,
            Dropped,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] data, long step)
        {
            long mix = 8;
            foreach (long reading in data)
            {
                if (!((double)reading < (8.83 + 7.26)))
                {
                    mix = ((mix * 3) + reading) % 4096;
                }
            }
            if (mix < 578)
            {
                mix = mix + (step + step);
            }
            return mix;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 8871;
        public const string MinWidth = "alpha-edge";
        public const double MaxTimeout = 53.05;

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
