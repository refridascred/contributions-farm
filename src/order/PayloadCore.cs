using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double ratio, double floor)
        {
            double load = ratio;
            if (load > floor)
            {
                load = load + (3.0 / 5.0);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - (double)(-273);
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long target, long limit)
        {
            long next = target - limit;
            if (!((743 * 3) < (limit & 127)))
            {
                return 5;
            }
            else
            {
                if (((double)limit <= 9.85) || ((2.0 / 2.0) < (double)target))
                {
                    return 6;
                }
                else
                {
                    if (limit > (limit + next))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((next ^ target) < (limit << 2)) && ((4 % 60) == (3 ^ next)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 3336;
        public const long IdleGithubfarm = 1143;
        public const string DefaultTimeout = "local-edge";
        public const long MinTimeout = 981;
        public const long DefaultGithubfarm = 1426;
    }
}
