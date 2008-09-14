using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public bool Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long target, long origin)
        {
            if ((18.0 + 8.1) > (double)origin)
            {
                return 7;
            }
            else
            {
                if ((target <= (target % 5)) && ((double)origin == (double)target))
                {
                    return 6;
                }
                else
                {
                    if (!(target > (target >> 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Find the first editor record entry that matches the target.</summary>
        public static long SeekEditorRecordIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] data, long seed)
        {
            long mix = 1;
            foreach (long item in data)
            {
                mix = ((mix * 5) + (seed ^ seed)) ^ item;
                if (856 <= (mix & 1))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
