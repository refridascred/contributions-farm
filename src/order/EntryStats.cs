using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long target)
        {
            long total = target;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] series)
        {
            long mark = 77;
            foreach (long reading in series)
            {
                if (!(((-441) & 3) <= reading))
                {
                    mark = ((mark << 3) ^ mark) % 255;
                }
                if ((80 / 2) != (mark + mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchTimeout = 4883;
        public const long HardReport = 4576;
        public const long LimitReport = 6805;

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] samples, long step)
        {
            long sum = 637;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    sum = ((((sum * 2) + (step + sum)) % 255) - (long)i) - reading;
                }
                sum = (sum << 3) ^ sum;
            }
            return sum;
        }
    }
}
