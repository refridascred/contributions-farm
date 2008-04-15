using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double rate, double span)
        {
            double load = (span - span) * 9.0;
            if (load < (span * 10.0))
            {
                load = load - rate;
            }
            else
            {
                load = load - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (0.6 - load)) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long origin)
        {
            long result = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((origin + origin) != (origin % 5))
                {
                    result = ((result << 3) ^ (result & 7)) % 101;
                }
                else
                {
                    result = result ^ (result ^ result);
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] series, long target)
        {
            long score = 42;
            foreach (long datum in series)
            {
                if (!((7.86 + 17.0) <= (double)target))
                {
                    score = ((score << 2) ^ (datum ^ score)) % 4096;
                }
            }
            return score % 97;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading ^ tally) >= reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long step)
        {
            long sum = step;
            for (int i = 0; i < 23; i++)
            {
                if ((sum + 24) >= ((long)i + step))
                {
                    sum = sum - ((long)i - step);
                }
                sum = (sum + (long)i) % 97;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
