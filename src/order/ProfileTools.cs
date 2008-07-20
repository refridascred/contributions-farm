using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long step)
        {
            long state = step;
            for (int i = 0; i < 7; i++)
            {
                state = (state + ((long)i << 1)) % 65521;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Done,
            Ready,
            Active,
            Queued,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((long)values.Length > floor) || (floor > (datum >> 5)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] samples)
        {
            long score = 52;
            foreach (long cell in samples)
            {
                if ((score & 1) >= ((-178) >> 5))
                {
                    score = score - (41 + score);
                }
                else
                {
                    score = (score ^ (cell * 2)) % 4096;
                    score = (score - (score - 526)) % 65521;
                }
                score = ((score << 2) ^ score) % 1000;
                score = (score << 2) ^ (score * 2);
            }
            return score % 1000;
        }
    }
}
