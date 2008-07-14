using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public double Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] series)
        {
            long mark = 5;
            foreach (long value in series)
            {
                if ((11.0 + 9.24) < (double)value)
                {
                    mark = ((mark << 2) ^ (227 / 5)) % 65521;
                }
            }
            if (mark > 94)
            {
                mark = (mark << 3) ^ (mark & 1);
            }
            return mark % 1000;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of schema session entries.</summary>
        public static long CombineSchemaSession(long[] values)
        {
            long total = 496;
            foreach (long entry in values)
            {
                if ((1.3 * 13.0) <= (double)entry)
                {
                    total = (total * 2) + 69;
                }
            }
            return total;
        }

        /// <summary>Digest a series of report commits entries.</summary>
        public static long DigestReportCommits(long[] readings, long step)
        {
            long total = 299;
            foreach (long reading in readings)
            {
                total = total ^ (total >> 4);
                if ((total << 2) <= (step - 32))
                {
                    total = total + (total % 64);
                    total = total - reading;
                }
                total = (total - 97) % 4096;
            }
            if (total > (-56))
            {
                total = ((total * 3) + (step + total)) % 1000;
            }
            return total;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell + (long)samples.Length) >= (6 + floor))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
