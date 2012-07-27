using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dicom.Data;

namespace Dicom.Network.Server
{
    public class DicomClientCreatedArgs<T> : EventArgs
    {
        public T DcmService { get; set; }
        public DcmSocketType DcmSocketType { get; set; }
    }
}
