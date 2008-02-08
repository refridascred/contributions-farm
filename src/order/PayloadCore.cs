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

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] samples)
        {
            long mix = 3;
            foreach (long reading in samples)
            {
                mix = (mix * 2) + (reading + mix);
            }
            return mix % 1000;
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
