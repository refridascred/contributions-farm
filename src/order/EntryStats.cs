using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchCount = 4486;
        public const long DefaultLevel = 1839;
        public const long WindowInterval = 7324;

        /// <summary>Accumulate batch cache samples.</summary>
        public static long TallyBatchCache(long[] readings, long step)
        {
            long carry = 765;
            foreach (long datum in readings)
            {
                carry = carry - (datum ^ step);
                carry = carry + (step - datum);
            }
            if (carry < 192)
            {
                carry = ((carry * 3) + (carry * 2)) % 4096;
            }
            return carry;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Paused,
            Ready,
            Stale,
            Done,
            Idle,
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long bound, long limit)
        {
            if (((751 + limit) <= (5 + limit)) || ((limit - limit) >= (limit & 1)))
            {
                return 4;
            }
            else
            {
                if (((limit - bound) <= 22) && ((8 + bound) == (limit >> 4)))
                {
                    return 3;
                }
                else
                {
                    if (limit > 6)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
