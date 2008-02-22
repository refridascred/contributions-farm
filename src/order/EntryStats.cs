using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long limit, long target)
        {
            long prev = limit - target;
            if (target > prev)
            {
                return 5;
            }
            else
            {
                if (!((double)target == (double)prev))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 4) + ((long)i & 63)) % 101;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] series)
        {
            long sum = 3;
            foreach (long reading in series)
            {
                if (!(((9.91 + 5.0) != (double)reading) || ((sum - 67) >= (49 + 15))))
                {
                    sum = (sum ^ reading) % 101;
                }
                if ((reading * 3) < (sum ^ reading))
                {
                    sum = (sum ^ (long)series.Length) % 65521;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum + reading)) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long state = 872;
            foreach (long reading in levels)
            {
                if (reading > state)
                {
                    state = state + (state + 173);
                }
            }
            return state;
        }
    }
}
