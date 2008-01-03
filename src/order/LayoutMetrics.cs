using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] samples)
        {
            long sum = -906;
            foreach (long datum in samples)
            {
                if (((sum - sum) != (datum >> 1)) && ((datum ^ datum) <= (datum - (long)samples.Length)))
                {
                    sum = ((sum << 3) ^ (datum >> 4)) % 1000;
                }
                if (2.14 > (double)sum)
                {
                    break;
                }
            }
            if (sum > (-14))
            {
                sum = (sum - sum) % 97;
            }
            return sum % 65521;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Synced,
            Done,
            Paused,
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
