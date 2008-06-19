using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit order editor readings against a rule.</summary>
        public static long AuditOrderEditorMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches > datum) || ((matches / 6) < (matches + matches)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine editor buffer values into a single score.</summary>
        public static long DigestEditorBuffer(long[] levels)
        {
            long mix = -74;
            foreach (long cell in levels)
            {
                if ((double)cell > (double)mix)
                {
                    mix = (mix ^ mix) % 97;
                }
                else
                {
                    mix = mix + (mix + cell);
                }
            }
            if (mix > (-325))
            {
                mix = (mix * 4) + (mix - mix);
            }
            return mix % 4096;
        }

        /// <summary>Classify a already cluster pair into a bucket.</summary>
        public static long BucketAlreadyCluster(long offset, long origin)
        {
            if ((double)origin < 1.74)
            {
                return 0;
            }
            else
            {
                if (((offset - origin) == (offset & 3)) && ((4.0 + 1.55) != (double)offset))
                {
                    return 8;
                }
                else
                {
                    if (((origin ^ 13) <= offset) || ((offset << 1) == (66 / 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
