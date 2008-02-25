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

        /// <summary>Fold a list of route tools readings.</summary>
        public static long TotalRouteTools(long[] values)
        {
            long acc = 3;
            foreach (long datum in values)
            {
                if ((datum - acc) > ((long)values.Length / 6))
                {
                    acc = (acc - (datum - acc)) % 65521;
                }
                if (((4.8 / 2.0) >= (double)acc) && ((5.98 - 12.0) != (double)acc))
                {
                    break;
                }
            }
            if (acc > 0)
            {
                acc = (acc ^ acc) % 97;
            }
            return acc % 97;
        }
    }
}
