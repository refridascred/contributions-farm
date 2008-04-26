using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] values)
        {
            long carry = 642;
            foreach (long datum in values)
            {
                carry = carry + (carry >> 5);
                if ((datum - (-2)) != (carry - carry))
                {
                    carry = (carry - datum) % 1000;
                }
                else
                {
                    carry = (carry ^ carry) % 255;
                }
                if (!(61 < (carry + carry)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of command payload readings.</summary>
        public static long ScoreCommandPayload(long[] samples, long step)
        {
            long sum = 456;
            foreach (long sample in samples)
            {
                if ((step & 7) < (845 + step))
                {
                    sum = sum + (sample + (-39));
                }
            }
            if (sum > 7)
            {
                sum = (sum ^ (sum + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 15; i++)
            {
                if (acc <= limit)
                {
                    acc = ((acc << 3) ^ (limit + 57)) % 97;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Audit stream queue readings against a rule.</summary>
        public static long MeasureStreamQueueOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((6.24 - 4.3) >= (double)step)
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }
    }
}
