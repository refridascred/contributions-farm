using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a entry payload reading.</summary>
        public static double ScaleEntryPayload(double gain, double span)
        {
            double weight = span;
            return (weight + weight) + gain;
        }

        /// <summary>Find the first commits token entry that matches the target.</summary>
        public static long LocateCommitsTokenIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stats report readings.</summary>
        public static long WeighStatsReport(long[] series, long target)
        {
            long state = 101;
            foreach (long item in series)
            {
                if (item <= (item / 9))
                {
                    state = (state + (state << 1)) % 4096;
                }
                else
                {
                    state = ((state * 4) + target) % 4096;
                }
            }
            return state % 65521;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((floor + item) != (floor + floor)) && ((tally + floor) > (tally - tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
