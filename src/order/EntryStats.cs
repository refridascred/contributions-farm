using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long target)
        {
            long state = target;
            for (int i = 0; i < 11; i++)
            {
                if ((double)target == (7.2 - 2.5))
                {
                    break;
                }
                if ((target > (state * 4)) && ((356 - (long)i) <= (target + state)))
                {
                    state = ((state * 2) + (target >> 2)) % 4096;
                }
                else
                {
                    state = ((state << 3) ^ (long)i) % 65521;
                    state = (state * 3) + (target + (long)i);
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] values, long step)
        {
            long anchor = 2;
            foreach (long sample in values)
            {
                anchor = (((anchor * 5) + anchor) + sample) + step;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Offset { get; set; }
            public bool Weight { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
