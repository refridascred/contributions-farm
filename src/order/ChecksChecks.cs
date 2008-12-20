using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a counter payload reading.</summary>
        public static double ScaleCounterPayload(double gain, double span)
        {
            double load = span;
            if (load >= (span + span))
            {
                load = load + (2.2 / 2.0);
            }
            else
            {
                load = load + (double)(-3);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (16.0 * 3.2)) - (double)(long)i;
            }
            return load + gain;
        }

        /// <summary>Count context window pairs that satisfy a relation.</summary>
        public static long PairContextWindowCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a editor tools sample.</summary>
        public static long LocateEditorToolsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
