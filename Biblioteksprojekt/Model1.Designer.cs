﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("LibraryDBModel", "FK_Book_Copy_Book", "Book", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Biblioteksprojekt.Book), "Book_Copy", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Biblioteksprojekt.Book_Copy), true)]
[assembly: EdmRelationshipAttribute("LibraryDBModel", "FK_Loan_Book_Copy", "Book_Copy", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Biblioteksprojekt.Book_Copy), "Loan", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Biblioteksprojekt.Loan), true)]
[assembly: EdmRelationshipAttribute("LibraryDBModel", "FK_Loan_Member", "Member", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Biblioteksprojekt.Member), "Loan", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Biblioteksprojekt.Loan), true)]
[assembly: EdmRelationshipAttribute("LibraryDBModel", "Written", "Author", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Biblioteksprojekt.Author), "Book", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Biblioteksprojekt.Book))]

#endregion

namespace Biblioteksprojekt
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class LibraryDBEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new LibraryDBEntities object using the connection string found in the 'LibraryDBEntities' section of the application configuration file.
        /// </summary>
        public LibraryDBEntities() : base("name=LibraryDBEntities", "LibraryDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new LibraryDBEntities object.
        /// </summary>
        public LibraryDBEntities(string connectionString) : base(connectionString, "LibraryDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new LibraryDBEntities object.
        /// </summary>
        public LibraryDBEntities(EntityConnection connection) : base(connection, "LibraryDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Author> Author
        {
            get
            {
                if ((_Author == null))
                {
                    _Author = base.CreateObjectSet<Author>("Author");
                }
                return _Author;
            }
        }
        private ObjectSet<Author> _Author;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Book> Book
        {
            get
            {
                if ((_Book == null))
                {
                    _Book = base.CreateObjectSet<Book>("Book");
                }
                return _Book;
            }
        }
        private ObjectSet<Book> _Book;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Book_Copy> Book_Copy
        {
            get
            {
                if ((_Book_Copy == null))
                {
                    _Book_Copy = base.CreateObjectSet<Book_Copy>("Book_Copy");
                }
                return _Book_Copy;
            }
        }
        private ObjectSet<Book_Copy> _Book_Copy;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Loan> Loan
        {
            get
            {
                if ((_Loan == null))
                {
                    _Loan = base.CreateObjectSet<Loan>("Loan");
                }
                return _Loan;
            }
        }
        private ObjectSet<Loan> _Loan;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Member> Member
        {
            get
            {
                if ((_Member == null))
                {
                    _Member = base.CreateObjectSet<Member>("Member");
                }
                return _Member;
            }
        }
        private ObjectSet<Member> _Member;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Author EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToAuthor(Author author)
        {
            base.AddObject("Author", author);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Book EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToBook(Book book)
        {
            base.AddObject("Book", book);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Book_Copy EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToBook_Copy(Book_Copy book_Copy)
        {
            base.AddObject("Book_Copy", book_Copy);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Loan EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToLoan(Loan loan)
        {
            base.AddObject("Loan", loan);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Member EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToMember(Member member)
        {
            base.AddObject("Member", member);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LibraryDBModel", Name="Author")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Author : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Author object.
        /// </summary>
        /// <param name="author_Id">Initial value of the Author_Id property.</param>
        /// <param name="author_Name">Initial value of the Author_Name property.</param>
        public static Author CreateAuthor(global::System.Int32 author_Id, global::System.String author_Name)
        {
            Author author = new Author();
            author.Author_Id = author_Id;
            author.Author_Name = author_Name;
            return author;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Author_Id
        {
            get
            {
                return _Author_Id;
            }
            set
            {
                if (_Author_Id != value)
                {
                    OnAuthor_IdChanging(value);
                    ReportPropertyChanging("Author_Id");
                    _Author_Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Author_Id");
                    OnAuthor_IdChanged();
                }
            }
        }
        private global::System.Int32 _Author_Id;
        partial void OnAuthor_IdChanging(global::System.Int32 value);
        partial void OnAuthor_IdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Author_Name
        {
            get
            {
                return _Author_Name;
            }
            set
            {
                OnAuthor_NameChanging(value);
                ReportPropertyChanging("Author_Name");
                _Author_Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Author_Name");
                OnAuthor_NameChanged();
            }
        }
        private global::System.String _Author_Name;
        partial void OnAuthor_NameChanging(global::System.String value);
        partial void OnAuthor_NameChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LibraryDBModel", "Written", "Book")]
        public EntityCollection<Book> Book
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Book>("LibraryDBModel.Written", "Book");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Book>("LibraryDBModel.Written", "Book", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LibraryDBModel", Name="Book")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Book : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Book object.
        /// </summary>
        /// <param name="book_Id">Initial value of the Book_Id property.</param>
        /// <param name="book_ISBN">Initial value of the Book_ISBN property.</param>
        /// <param name="book_Title">Initial value of the Book_Title property.</param>
        public static Book CreateBook(global::System.Int32 book_Id, global::System.String book_ISBN, global::System.String book_Title)
        {
            Book book = new Book();
            book.Book_Id = book_Id;
            book.Book_ISBN = book_ISBN;
            book.Book_Title = book_Title;
            return book;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Book_Id
        {
            get
            {
                return _Book_Id;
            }
            set
            {
                if (_Book_Id != value)
                {
                    OnBook_IdChanging(value);
                    ReportPropertyChanging("Book_Id");
                    _Book_Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Book_Id");
                    OnBook_IdChanged();
                }
            }
        }
        private global::System.Int32 _Book_Id;
        partial void OnBook_IdChanging(global::System.Int32 value);
        partial void OnBook_IdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Book_ISBN
        {
            get
            {
                return _Book_ISBN;
            }
            set
            {
                OnBook_ISBNChanging(value);
                ReportPropertyChanging("Book_ISBN");
                _Book_ISBN = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Book_ISBN");
                OnBook_ISBNChanged();
            }
        }
        private global::System.String _Book_ISBN;
        partial void OnBook_ISBNChanging(global::System.String value);
        partial void OnBook_ISBNChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Book_Title
        {
            get
            {
                return _Book_Title;
            }
            set
            {
                OnBook_TitleChanging(value);
                ReportPropertyChanging("Book_Title");
                _Book_Title = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Book_Title");
                OnBook_TitleChanged();
            }
        }
        private global::System.String _Book_Title;
        partial void OnBook_TitleChanging(global::System.String value);
        partial void OnBook_TitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Book_Description
        {
            get
            {
                return _Book_Description;
            }
            set
            {
                OnBook_DescriptionChanging(value);
                ReportPropertyChanging("Book_Description");
                _Book_Description = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Book_Description");
                OnBook_DescriptionChanged();
            }
        }
        private global::System.String _Book_Description;
        partial void OnBook_DescriptionChanging(global::System.String value);
        partial void OnBook_DescriptionChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LibraryDBModel", "FK_Book_Copy_Book", "Book_Copy")]
        public EntityCollection<Book_Copy> Book_Copy
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Book_Copy>("LibraryDBModel.FK_Book_Copy_Book", "Book_Copy");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Book_Copy>("LibraryDBModel.FK_Book_Copy_Book", "Book_Copy", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LibraryDBModel", "Written", "Author")]
        public EntityCollection<Author> Author
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Author>("LibraryDBModel.Written", "Author");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Author>("LibraryDBModel.Written", "Author", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LibraryDBModel", Name="Book_Copy")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Book_Copy : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Book_Copy object.
        /// </summary>
        /// <param name="book_Copy_Id">Initial value of the Book_Copy_Id property.</param>
        /// <param name="book_id">Initial value of the Book_id property.</param>
        /// <param name="loaned">Initial value of the Loaned property.</param>
        public static Book_Copy CreateBook_Copy(global::System.Int32 book_Copy_Id, global::System.Int32 book_id, global::System.Boolean loaned)
        {
            Book_Copy book_Copy = new Book_Copy();
            book_Copy.Book_Copy_Id = book_Copy_Id;
            book_Copy.Book_id = book_id;
            book_Copy.Loaned = loaned;
            return book_Copy;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Book_Copy_Id
        {
            get
            {
                return _Book_Copy_Id;
            }
            set
            {
                if (_Book_Copy_Id != value)
                {
                    OnBook_Copy_IdChanging(value);
                    ReportPropertyChanging("Book_Copy_Id");
                    _Book_Copy_Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Book_Copy_Id");
                    OnBook_Copy_IdChanged();
                }
            }
        }
        private global::System.Int32 _Book_Copy_Id;
        partial void OnBook_Copy_IdChanging(global::System.Int32 value);
        partial void OnBook_Copy_IdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Book_id
        {
            get
            {
                return _Book_id;
            }
            set
            {
                OnBook_idChanging(value);
                ReportPropertyChanging("Book_id");
                _Book_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Book_id");
                OnBook_idChanged();
            }
        }
        private global::System.Int32 _Book_id;
        partial void OnBook_idChanging(global::System.Int32 value);
        partial void OnBook_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Loaned
        {
            get
            {
                return _Loaned;
            }
            set
            {
                OnLoanedChanging(value);
                ReportPropertyChanging("Loaned");
                _Loaned = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Loaned");
                OnLoanedChanged();
            }
        }
        private global::System.Boolean _Loaned;
        partial void OnLoanedChanging(global::System.Boolean value);
        partial void OnLoanedChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LibraryDBModel", "FK_Book_Copy_Book", "Book")]
        public Book Book
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Book>("LibraryDBModel.FK_Book_Copy_Book", "Book").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Book>("LibraryDBModel.FK_Book_Copy_Book", "Book").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Book> BookReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Book>("LibraryDBModel.FK_Book_Copy_Book", "Book");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Book>("LibraryDBModel.FK_Book_Copy_Book", "Book", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LibraryDBModel", "FK_Loan_Book_Copy", "Loan")]
        public EntityCollection<Loan> Loan
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Loan>("LibraryDBModel.FK_Loan_Book_Copy", "Loan");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Loan>("LibraryDBModel.FK_Loan_Book_Copy", "Loan", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LibraryDBModel", Name="Loan")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Loan : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Loan object.
        /// </summary>
        /// <param name="loan_Time_Of_Loan">Initial value of the Loan_Time_Of_Loan property.</param>
        /// <param name="loan_Due_Date">Initial value of the Loan_Due_Date property.</param>
        /// <param name="book_Copy_Id">Initial value of the Book_Copy_Id property.</param>
        /// <param name="member_Id">Initial value of the Member_Id property.</param>
        public static Loan CreateLoan(global::System.DateTime loan_Time_Of_Loan, global::System.DateTime loan_Due_Date, global::System.Int32 book_Copy_Id, global::System.Int32 member_Id)
        {
            Loan loan = new Loan();
            loan.Loan_Time_Of_Loan = loan_Time_Of_Loan;
            loan.Loan_Due_Date = loan_Due_Date;
            loan.Book_Copy_Id = book_Copy_Id;
            loan.Member_Id = member_Id;
            return loan;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime Loan_Time_Of_Loan
        {
            get
            {
                return _Loan_Time_Of_Loan;
            }
            set
            {
                if (_Loan_Time_Of_Loan != value)
                {
                    OnLoan_Time_Of_LoanChanging(value);
                    ReportPropertyChanging("Loan_Time_Of_Loan");
                    _Loan_Time_Of_Loan = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Loan_Time_Of_Loan");
                    OnLoan_Time_Of_LoanChanged();
                }
            }
        }
        private global::System.DateTime _Loan_Time_Of_Loan;
        partial void OnLoan_Time_Of_LoanChanging(global::System.DateTime value);
        partial void OnLoan_Time_Of_LoanChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime Loan_Due_Date
        {
            get
            {
                return _Loan_Due_Date;
            }
            set
            {
                if (_Loan_Due_Date != value)
                {
                    OnLoan_Due_DateChanging(value);
                    ReportPropertyChanging("Loan_Due_Date");
                    _Loan_Due_Date = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Loan_Due_Date");
                    OnLoan_Due_DateChanged();
                }
            }
        }
        private global::System.DateTime _Loan_Due_Date;
        partial void OnLoan_Due_DateChanging(global::System.DateTime value);
        partial void OnLoan_Due_DateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Book_Copy_Id
        {
            get
            {
                return _Book_Copy_Id;
            }
            set
            {
                if (_Book_Copy_Id != value)
                {
                    OnBook_Copy_IdChanging(value);
                    ReportPropertyChanging("Book_Copy_Id");
                    _Book_Copy_Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Book_Copy_Id");
                    OnBook_Copy_IdChanged();
                }
            }
        }
        private global::System.Int32 _Book_Copy_Id;
        partial void OnBook_Copy_IdChanging(global::System.Int32 value);
        partial void OnBook_Copy_IdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Member_Id
        {
            get
            {
                return _Member_Id;
            }
            set
            {
                if (_Member_Id != value)
                {
                    OnMember_IdChanging(value);
                    ReportPropertyChanging("Member_Id");
                    _Member_Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Member_Id");
                    OnMember_IdChanged();
                }
            }
        }
        private global::System.Int32 _Member_Id;
        partial void OnMember_IdChanging(global::System.Int32 value);
        partial void OnMember_IdChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LibraryDBModel", "FK_Loan_Book_Copy", "Book_Copy")]
        public Book_Copy Book_Copy
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Book_Copy>("LibraryDBModel.FK_Loan_Book_Copy", "Book_Copy").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Book_Copy>("LibraryDBModel.FK_Loan_Book_Copy", "Book_Copy").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Book_Copy> Book_CopyReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Book_Copy>("LibraryDBModel.FK_Loan_Book_Copy", "Book_Copy");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Book_Copy>("LibraryDBModel.FK_Loan_Book_Copy", "Book_Copy", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LibraryDBModel", "FK_Loan_Member", "Member")]
        public Member Member
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Member>("LibraryDBModel.FK_Loan_Member", "Member").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Member>("LibraryDBModel.FK_Loan_Member", "Member").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Member> MemberReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Member>("LibraryDBModel.FK_Loan_Member", "Member");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Member>("LibraryDBModel.FK_Loan_Member", "Member", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LibraryDBModel", Name="Member")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Member : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Member object.
        /// </summary>
        /// <param name="member_Id">Initial value of the Member_Id property.</param>
        /// <param name="member_Personal_Id">Initial value of the Member_Personal_Id property.</param>
        /// <param name="member_Name">Initial value of the Member_Name property.</param>
        public static Member CreateMember(global::System.Int32 member_Id, global::System.String member_Personal_Id, global::System.String member_Name)
        {
            Member member = new Member();
            member.Member_Id = member_Id;
            member.Member_Personal_Id = member_Personal_Id;
            member.Member_Name = member_Name;
            return member;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Member_Id
        {
            get
            {
                return _Member_Id;
            }
            set
            {
                if (_Member_Id != value)
                {
                    OnMember_IdChanging(value);
                    ReportPropertyChanging("Member_Id");
                    _Member_Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Member_Id");
                    OnMember_IdChanged();
                }
            }
        }
        private global::System.Int32 _Member_Id;
        partial void OnMember_IdChanging(global::System.Int32 value);
        partial void OnMember_IdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Member_Personal_Id
        {
            get
            {
                return _Member_Personal_Id;
            }
            set
            {
                OnMember_Personal_IdChanging(value);
                ReportPropertyChanging("Member_Personal_Id");
                _Member_Personal_Id = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Member_Personal_Id");
                OnMember_Personal_IdChanged();
            }
        }
        private global::System.String _Member_Personal_Id;
        partial void OnMember_Personal_IdChanging(global::System.String value);
        partial void OnMember_Personal_IdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Member_Name
        {
            get
            {
                return _Member_Name;
            }
            set
            {
                OnMember_NameChanging(value);
                ReportPropertyChanging("Member_Name");
                _Member_Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Member_Name");
                OnMember_NameChanged();
            }
        }
        private global::System.String _Member_Name;
        partial void OnMember_NameChanging(global::System.String value);
        partial void OnMember_NameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Member_Email
        {
            get
            {
                return _Member_Email;
            }
            set
            {
                OnMember_EmailChanging(value);
                ReportPropertyChanging("Member_Email");
                _Member_Email = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Member_Email");
                OnMember_EmailChanged();
            }
        }
        private global::System.String _Member_Email;
        partial void OnMember_EmailChanging(global::System.String value);
        partial void OnMember_EmailChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LibraryDBModel", "FK_Loan_Member", "Loan")]
        public EntityCollection<Loan> Loan
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Loan>("LibraryDBModel.FK_Loan_Member", "Loan");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Loan>("LibraryDBModel.FK_Loan_Member", "Loan", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
