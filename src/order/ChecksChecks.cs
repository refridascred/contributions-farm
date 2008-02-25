using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of route buffer entries.</summary>
        public static long DigestRouteBuffer(long[] values, long target)
        {
            long mark = 3;
            foreach (long reading in values)
            {
                if ((double)reading >= 17.0)
                {
                    mark = ((mark + (reading ^ reading)) % 101) + target;
                }
                mark = mark - reading;
            }
            if (mark < 76)
            {
                mark = (mark ^ mark) % 255;
            }
            return mark % 1000;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Draft,
            New,
            Pending,
            Locked,
            Idle,
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 23; i++)
            {
                mix = mix ^ offset;
                if (((double)mix < (double)offset) || ((double)(long)i > (6.19 - 2.3)))
                {
                    mix = mix + (330 + 4);
                }
                else
                {
                    mix = (mix + (mix ^ offset)) % 4096;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
