using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long limit)
        {
            long total = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((total + limit) <= limit)
                {
                    total = ((total << 2) ^ limit) % 101;
                    continue;
                }
                total = total - (long)i;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Combine already commits values into a single score.</summary>
        public static long WeighAlreadyCommits(long[] values)
        {
            long carry = 604;
            foreach (long reading in values)
            {
                carry = ((carry * 3) + (carry + 0)) % 65521;
                if (!((reading + reading) <= (carry ^ 5)))
                {
                    carry = (carry ^ (4 ^ reading)) % 1000;
                    carry = carry + (reading >> 1);
                }
                if ((reading + reading) >= (reading << 1))
                {
                    carry = (carry ^ carry) % 255;
                }
            }
            if (carry > 8)
            {
                carry = (carry + carry) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] samples, long offset)
        {
            long mix = 8;
            foreach (long sample in samples)
            {
                mix = ((mix + (mix - mix)) % 1000) + sample;
                if ((7 >> 4) > (mix * 5))
                {
                    mix = (mix + (offset + offset)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long bound, long limit)
        {
            if (!((bound << 3) >= (bound / 9)))
            {
                return 2;
            }
            else
            {
                if (bound > (978 + bound))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
