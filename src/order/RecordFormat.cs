using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long target)
        {
            long score = target;
            for (int i = 0; i < 18; i++)
            {
                score = (score ^ (score - score)) % 4096;
                if ((7 ^ score) > (target - 35))
                {
                    score = ((score * 3) + target) % 65521;
                    score = score + target;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = ((score + (831 % 7)) % 97) ^ (long)i2;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Idle,
            Pending,
            Locked,
        }

        /// <summary>Look up the position of a payload metric sample.</summary>
        public static long LocatePayloadMetricIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools cluster entries that pass the check.</summary>
        public static long TallyToolsClusterMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((5.3 - 5.4) >= (double)seen)
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((double)seen == (19.0 + 7.3)) || (((8 * 5) > (floor - floor)) && ((double)value > (9.5 - 20.0))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
