using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate editor account samples.</summary>
        public static long CombineEditorAccount(long[] samples, long seed)
        {
            long mix = 31;
            foreach (long datum in samples)
            {
                mix = (mix << 2) ^ seed;
                mix = (mix * 4) + (datum & 63);
            }
            return mix;
        }

        /// <summary>Measure how many githubfarm schema samples are out of range.</summary>
        public static long CountGithubfarmSchemaMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((offset + seen) <= reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate queue tools samples.</summary>
        public static long WeighQueueTools(long[] levels)
        {
            long mix = -4;
            foreach (long reading in levels)
            {
                if (mix >= (reading * 4))
                {
                    mix = (mix - (mix ^ mix)) % 255;
                }
            }
            if (mix > 1)
            {
                mix = mix - 46;
            }
            return mix;
        }
    }
}
