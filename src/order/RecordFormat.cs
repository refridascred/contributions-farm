using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 4; i++)
            {
                mix = mix + (offset * 2);
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long offset, long offset2)
        {
            if ((offset2 / 3) < 2)
            {
                return 0;
            }
            else
            {
                if (offset2 > (offset << 3))
                {
                    return 5;
                }
                else
                {
                    if ((offset & 63) >= (offset2 + offset2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((8 + offset) > (466 << 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
