using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long bound, long seed)
        {
            long delta = bound + seed;
            if ((bound > 11) || ((bound >> 3) < (bound & 31)))
            {
                return 8;
            }
            else
            {
                if ((double)delta == (double)793)
                {
                    return 6;
                }
                else
                {
                    if ((double)bound < 0.18)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound * 3) != (42 << 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next already buffer value from a seed.</summary>
        public static long RollAlreadyBuffer(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] data, long offset)
        {
            long mark = 692;
            foreach (long value in data)
            {
                mark = (mark - offset) ^ value;
                if ((96 % 12) >= mark)
                {
                    mark = ((mark << 3) ^ (offset + 743)) % 97;
                }
            }
            if (mark < 57)
            {
                mark = (mark + (mark ^ 771)) % 255;
            }
            return mark;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
