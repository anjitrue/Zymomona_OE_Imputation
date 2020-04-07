using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImputeMissing_OverExpression_Values
{
    public class Replicate
    {
        public List<LfqValues> lfqValues;
        public string conditionName;
        public string replicateName;
        public int readerIndex;

        public Replicate(string header, int readerIndex)
        {
            /* logic for h3k spreadsheet 
             * 
            var parsedHeader = header.Replace("LFQ intensity ", "").Split('_');

            if (!parsedHeader[1].Equals("pWT"))
            {
                this.conditionName = parsedHeader[0];
                this.replicateName = parsedHeader[1];
            }
            else
            {
                this.conditionName = parsedHeader[0] + "_" + parsedHeader[1];
                this.replicateName = parsedHeader[2];
            }
            */

            var parsedHeader = header.Split('_');
                this.conditionName = parsedHeader[0];
                this.replicateName = parsedHeader[1];
                //this.replicateName = parsedHeader[0];

                this.lfqValues = new List<LfqValues>();
                this.readerIndex = readerIndex;
        



        }
    }
}
