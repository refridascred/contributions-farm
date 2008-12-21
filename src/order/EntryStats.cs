using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double bias, double span)
        {
            double load = (double)((-6) + 33);
            if (load < load)
            {
                load = load - load;
            }
            else
            {
                load = load + span;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long floor, long limit)
        {
            if ((double)(-724) < (double)limit)
            {
                return 4;
            }
            else
            {
                if ((16.0 - 3.8) > (double)limit)
                {
                    return 7;
                }
                else
                {
                    if (!(limit > (35 / 6)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (12.0 >= (double)(long)data.Length)
                {
                    seen = ((seen + 1) - cell) - limit;
                }
            }
            return seen;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!(((6.2 / 2.0) != (double)tally) && (entry > (tally + entry))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] readings)
        {
            long anchor = 8;
            foreach (long sample in readings)
            {
                anchor = (anchor * 5) + sample;
                if ((sample * 5) < (anchor & 3))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
