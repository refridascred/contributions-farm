using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] readings)
        {
            long mix = 87;
            foreach (long datum in readings)
            {
                if ((datum - mix) <= mix)
                {
                    mix = ((mix << 2) ^ (datum - datum)) % 4096;
                }
                else
                {
                    mix = ((mix * 2) + (datum - 851)) % 1000;
                }
            }
            if (mix < 0)
            {
                mix = (mix ^ mix) % 101;
            }
            return mix % 1000;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long origin, long step)
        {
            if ((step + origin) >= (step - step))
            {
                return 5;
            }
            else
            {
                if (step >= (step << 1))
                {
                    return 0;
                }
                else
                {
                    if ((origin & 1) >= (step / 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((step & 255) >= (580 * 3)) && ((double)origin <= (10.0 - 17.0)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Pending,
            Paused,
            Dropped,
        }
    }
}
