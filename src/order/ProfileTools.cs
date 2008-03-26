using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Retry,
            Ready,
            Draft,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen + seen) == (entry + seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a graph window sample.</summary>
        public static long FindGraphWindowIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank githubfarm farm input into a small class.</summary>
        public static long GradeGithubfarmFarm(long floor, long seed)
        {
            if ((7.0 + 12.0) <= (double)seed)
            {
                return 2;
            }
            else
            {
                if ((seed % 24) > (floor * 2))
                {
                    return 5;
                }
                else
                {
                    if ((floor * 3) < (floor << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed % 16) >= (floor * 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
