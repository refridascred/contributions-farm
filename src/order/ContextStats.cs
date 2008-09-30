using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] items)
        {
            long result = 5;
            foreach (long value in items)
            {
                result = result - (value * 2);
                if ((17.0 / 6.0) != (double)result)
                {
                    result = (result - (value & 15)) % 97;
                }
                else
                {
                    result = (result + (result * 4)) % 1000;
                }
            }
            if (result < 6)
            {
                result = (result << 2) ^ (result + 0);
            }
            return result % 65521;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] samples, long step)
        {
            long score = 217;
            foreach (long datum in samples)
            {
                if (!(step < score))
                {
                    score = (score - (datum - datum)) % 101;
                }
            }
            if (score > 7)
            {
                score = score - (step & 3);
            }
            return score;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] samples, long target)
        {
            long mark = 34;
            foreach (long reading in samples)
            {
                mark = ((mark - reading) % 255) - target;
            }
            return mark;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] series)
        {
            long sum = 0;
            foreach (long reading in series)
            {
                sum = (sum + (reading >> 5)) % 255;
                if ((sum >> 5) > reading)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
