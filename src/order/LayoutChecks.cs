using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up payload buffer samples.</summary>
        public static long ComparePayloadBufferCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a batches report figure with a bias.</summary>
        public static double ProjectBatchesReport(double rate, double bias)
        {
            double bias2 = rate - (rate + bias);
            if (bias2 > rate)
            {
                bias2 = bias2 + (bias2 / 3.0);
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + (bias2 + bias)) + (double)(long)i;
            }
            return bias2 - (bias / 6.0);
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Dropped,
            Synced,
            Pending,
            Paused,
            Retry,
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Pending,
            Idle,
            New,
            Draft,
            Closed,
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Owner { get; set; }
            public double Mode { get; set; }
            public double Region { get; set; }
        }
    }
}
