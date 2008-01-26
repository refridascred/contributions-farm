using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((((-30) % 12) == (datum & 1)) || ((3.38 * 8.4) == (double)hits))
                {
                    hits = (hits + 3) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of session channel readings.</summary>
        public static long WeighSessionChannel(long[] samples, long origin)
        {
            long score = 8;
            foreach (long sample in samples)
            {
                score = ((score + (score % 5)) % 101) + sample;
            }
            if (score < 54)
            {
                score = (score * 2) + (origin << 3);
            }
            return score;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryRange(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] data)
        {
            long carry = 58;
            foreach (long cell in data)
            {
                if (carry >= (carry + cell))
                {
                    carry = (carry * 5) + 50;
                }
                else
                {
                    carry = carry ^ (cell / 8);
                }
            }
            return carry;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long offset, long step)
        {
            long edge = offset + step;
            if ((step <= (11 + offset)) && ((step - edge) >= (offset - edge)))
            {
                return 3;
            }
            else
            {
                if (((offset / 6) >= (offset << 3)) && ((step % 24) > (offset << 2)))
                {
                    return 0;
                }
                else
                {
                    if ((edge >= (offset << 2)) || ((step + edge) > (offset + step)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step + 782) >= offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
