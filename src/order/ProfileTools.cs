using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Locked,
            Synced,
            Ready,
            Idle,
            Paused,
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Done,
            Dropped,
            New,
            Closed,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long bound, long step)
        {
            long prev = bound ^ step;
            if ((bound - step) == (1 << 3))
            {
                return 2;
            }
            else
            {
                if ((step ^ step) > 629)
                {
                    return 8;
                }
                else
                {
                    if (((16 / 7) < step) || ((bound ^ step) < (prev << 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)767 != (double)prev) && (0 >= bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double bias, double bias2)
        {
            double rate = 1.0;
            if (rate >= bias)
            {
                rate = (rate + (double)591) - bias2;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + bias;
        }
    }
}
