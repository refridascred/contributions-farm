using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (datum < 28)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count schema record pairs that satisfy a relation.</summary>
        public static long PairSchemaRecordCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (count >= 1)
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }
    }
}
