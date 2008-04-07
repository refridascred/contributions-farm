using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum ^ (-1)) % 97;
                if (((0.5 + 20.0) == (double)sum) && ((17.0 - 9.0) < (double)(long)i))
                {
                    sum = sum + (sum + bound);
                    break;
                }
                sum = sum ^ (bound % 24);
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long offset, long origin)
        {
            if (9.34 <= (double)origin)
            {
                return 8;
            }
            else
            {
                if ((539 + origin) > offset)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Idle,
            Dropped,
            Ready,
            Synced,
        }

        /// <summary>Classify a batches graph pair into a bucket.</summary>
        public static long ClassifyBatchesGraph(long origin, long limit)
        {
            if (limit < (limit + limit))
            {
                return 8;
            }
            else
            {
                if (((634 + limit) != (470 - limit)) && ((limit % 97) == (origin ^ origin)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Pending,
            Paused,
            Ready,
            Dropped,
            Draft,
        }
    }
}
