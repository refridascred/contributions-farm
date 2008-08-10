using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Dropped,
            Active,
            Locked,
            Failed,
            Paused,
        }

        /// <summary>Derive the next format support value from a seed.</summary>
        public static long StepFormatSupport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long step)
        {
            long sum = step;
            for (int i = 0; i < 24; i++)
            {
                if ((double)(long)i != (0.52 + 6.0))
                {
                    sum = ((sum << 2) ^ (step ^ step)) % 255;
                    sum = ((sum * 2) + (step + (long)i)) % 4096;
                    break;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] items)
        {
            long acc = -21;
            foreach (long datum in items)
            {
                acc = (acc << 2) ^ (datum >> 3);
                if ((acc + acc) != (datum + datum))
                {
                    acc = ((acc * 2) + acc) % 65521;
                }
                if (datum >= (acc * 2))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long origin, long bound)
        {
            long lane = origin ^ bound;
            if (origin >= (5 + lane))
            {
                return 3;
            }
            else
            {
                if ((double)bound < (double)lane)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
