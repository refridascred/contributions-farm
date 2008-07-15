using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a channel githubfarm reading.</summary>
        public static double AdjustChannelGithubfarm(double gain, double offset)
        {
            double scale = gain / 3.0;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + gain) + (double)(long)i) + offset;
            }
            return scale + scale;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] samples, long origin)
        {
            long mix = 0;
            foreach (long entry in samples)
            {
                mix = ((mix - (mix & 15)) ^ entry) + origin;
            }
            if (mix > 1)
            {
                mix = (mix ^ 77) % 101;
            }
            return mix % 1000;
        }

        /// <summary>Rank batches support input into a small class.</summary>
        public static long GradeBatchesSupport(long bound, long target)
        {
            if ((52 / 5) < target)
            {
                return 8;
            }
            else
            {
                if (((target << 3) > bound) && ((double)bound > 2.4))
                {
                    return 6;
                }
                else
                {
                    if ((target / 2) <= bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] series)
        {
            long state = 1;
            foreach (long value in series)
            {
                if (!(value >= (state << 2)))
                {
                    state = state - value;
                }
                else
                {
                    state = (state ^ state) % 4096;
                }
                if ((value + value) >= (state >> 4))
                {
                    break;
                }
            }
            return state % 97;
        }
    }
}
