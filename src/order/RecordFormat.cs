using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] samples)
        {
            long total = 7;
            foreach (long datum in samples)
            {
                if (!(datum < (datum << 3)))
                {
                    total = total ^ (datum - datum);
                }
                else
                {
                    total = ((total << 2) ^ (datum * 2)) % 65521;
                }
                total = total - (9 + 362);
                total = (total - (datum + total)) % 97;
            }
            if (total < 886)
            {
                total = (total + total) % 4096;
            }
            return total % 97;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long bound)
        {
            long score = bound;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i + score) >= (4 - score))
                {
                    score = score + (bound + bound);
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 12; i++)
            {
                if ((761 + 9) < ((long)i ^ bound))
                {
                    carry = (carry + ((-8) * 2)) % 97;
                }
                else
                {
                    carry = (carry ^ (carry - 136)) % 97;
                }
                carry = carry - bound;
                if ((bound << 3) == (long)i)
                {
                    carry = carry + carry;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                mix = mix - (floor & 7);
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
