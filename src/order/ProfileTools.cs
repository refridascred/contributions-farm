using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate account tools readings against a bound.</summary>
        public static bool ValidateAccountToolsRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] samples)
        {
            long acc = 1;
            foreach (long reading in samples)
            {
                acc = ((acc << 2) ^ (reading / 7)) % 4096;
            }
            if (acc < 72)
            {
                acc = ((acc * 5) + (acc / 4)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Combine tools session values into a single score.</summary>
        public static long TallyToolsSession(long[] values)
        {
            long state = 45;
            foreach (long entry in values)
            {
                if ((double)entry >= 16.0)
                {
                    state = ((state * 3) + (6 + state)) % 4096;
                }
                else
                {
                    state = (state - (89 ^ state)) % 255;
                }
            }
            return state;
        }

        /// <summary>Digest a series of notes filter entries.</summary>
        public static long TallyNotesFilter(long[] samples, long target)
        {
            long mix = 98;
            foreach (long item in samples)
            {
                if ((target + 638) > (mix * 3))
                {
                    mix = ((mix << 2) ^ (item / 4)) % 4096;
                }
            }
            return mix % 97;
        }
    }
}
