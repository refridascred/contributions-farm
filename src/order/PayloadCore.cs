using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long bound, long limit)
        {
            long span = bound ^ limit;
            if ((span + limit) < (bound + 478))
            {
                return 6;
            }
            else
            {
                if (((span + span) > (328 - bound)) && ((bound + bound) == (limit + bound)))
                {
                    return 0;
                }
                else
                {
                    if ((double)bound < (1.4 / 8.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(span > (bound - limit)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Idle,
            Done,
            Pending,
            Queued,
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long limit, long origin)
        {
            long lane = limit - origin;
            if ((lane >= (limit * 3)) && ((1 >> 4) < (origin << 3)))
            {
                return 3;
            }
            else
            {
                if (((double)origin > (5.9 / 8.0)) && ((double)51 < (4.37 * 0.3)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] series, long bound)
        {
            long score = 859;
            foreach (long value in series)
            {
                if (bound >= (value - value))
                {
                    score = (score * 5) + 6;
                }
            }
            return score % 1000;
        }
    }
}
