using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TPGestaoDeObraPOO.Moldels
{
    public class Document
    {

        #region Public Properties
        public int DocumentId { get; private set; }
        public DocumentType DocumentType { get; set; }
        public DateOnly DocumentDate { get; private set; }
        public Person Seller { get; set; }
        #endregion

        #region Constructor
        public Documents(int documentId, DocumentType documentType, DateOnly documentDate, Person seller)
        {
            this.DocumentId = documentId;
            this.DocumentType = documentType;
            this.DocumentDate = documentDate;
            this.Seller = seller;
        }
        #endregion
    }
}

