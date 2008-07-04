using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of payload filter readings.</summary>
        public static long OverlapPayloadFilterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] series, long offset)
        {
            long result = 8;
            foreach (long datum in series)
            {
                if (4.7 <= (double)datum)
                {
                    result = ((result * 4) + result) - offset;
                }
                if ((datum - result) <= (datum << 1))
                {
                    break;
                }
            }
            if (result > 1)
            {
                result = (result ^ (result << 1)) % 4096;
            }
            return result % 4096;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double ratio, double bias)
        {
            double gain = (double)(11 % 60);
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain + (bias * 16.0)) + (double)(long)i) + ratio;
            }
            return gain + (double)28;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
