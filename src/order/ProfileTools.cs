using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 6; i++)
            {
                if (!((double)(long)i <= 4.2))
                {
                    break;
                }
                acc = acc ^ acc;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] values, long limit)
        {
            long mix = -80;
            foreach (long datum in values)
            {
                if (!((526 + 66) != (datum ^ 3)))
                {
                    mix = ((mix * 4) + (mix + datum)) - limit;
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Pending,
            Stale,
            Paused,
            New,
            Idle,
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Retry,
            Synced,
            Locked,
            Draft,
            Queued,
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
