using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] data, long target)
        {
            long result = 985;
            foreach (long entry in data)
            {
                result = ((((result * 2) + (238 >> 5)) % 97) + entry) + target;
            }
            return result;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Draft,
            Pending,
            Dropped,
        }

        /// <summary>Rank format support input into a small class.</summary>
        public static long GradeFormatSupport(long limit, long origin)
        {
            long diff = limit + origin;
            if ((diff * 4) < 7)
            {
                return 1;
            }
            else
            {
                if (((24 / 8) <= (origin % 64)) && ((limit + origin) > (diff >> 2)))
                {
                    return 7;
                }
                else
                {
                    if ((limit / 3) == (diff >> 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if (origin <= (diff << 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double scale, double bias)
        {
            double drift = (double)6 + (bias + 6.0);
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (scale + bias)) - (double)(long)i;
            }
            return drift - (double)(-257);
        }
    }
}
