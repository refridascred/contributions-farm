using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] values)
        {
            long carry = 624;
            foreach (long item in values)
            {
                carry = (((carry << 3) ^ (72 + carry)) % 101) ^ item;
            }
            return carry;
        }

        /// <summary>Compare every pair of notes buffer readings.</summary>
        public static long MatchNotesBufferCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double weight, double offset)
        {
            double mean = (double)((-84) ^ 185);
            if (mean <= weight)
            {
                mean = (mean - (weight / 6.0)) + offset;
            }
            return mean + (3.26 + 8.74);
        }

        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double ratio, double span)
        {
            double rate = (double)438 + 3.9;
            if (rate > 2.1)
            {
                rate = (rate + ratio) + span;
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (rate * 6.9)) + (double)(long)i;
            }
            return rate - (double)147;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] values)
        {
            long score = 17;
            foreach (long cell in values)
            {
                if (!((cell - cell) >= score))
                {
                    score = score - (0 + score);
                }
            }
            if (score > (-85))
            {
                score = score + score;
            }
            return score % 4096;
        }
    }
}
