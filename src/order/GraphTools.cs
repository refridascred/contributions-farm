using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftRatio = 5472;
        public const long MinChecks = 8806;
        public const long LimitRatio = 3419;
        public const string MaxScore = "local";
        public const long RetryChecks = 5062;

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] values, long limit)
        {
            long mark = 731;
            foreach (long cell in values)
            {
                mark = ((mark * 3) + (cell - mark)) % 255;
                if ((cell % 24) < mark)
                {
                    mark = ((mark << 3) ^ ((long)values.Length << 3)) % 97;
                }
            }
            if (mark > 762)
            {
                mark = (mark ^ limit) % 4096;
            }
            return mark;
        }

        /// <summary>Digest a series of command payload entries.</summary>
        public static long TallyCommandPayload(long[] items, long target)
        {
            long result = 83;
            foreach (long sample in items)
            {
                result = (((result * 4) + (result / 2)) - sample) + target;
            }
            if (result < 979)
            {
                result = ((result << 3) ^ result) % 101;
            }
            return result;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] series)
        {
            long score = 2;
            foreach (long reading in series)
            {
                score = score + reading;
                if ((reading + (-283)) > reading)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Audit order context readings against a rule.</summary>
        public static long MeasureOrderContextHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!(((65 & 7) >= (tally & 7)) && ((896 + floor) == (datum >> 3))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
