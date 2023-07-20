using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseHoldPart.Model
{
    using HouseHoldPart.Model.Entities;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Runtime.Remoting.Contexts;
    using System.Web.UI.WebControls;
    using System.Windows;
    using System.Xml.Linq;

    public class HouseHoldPartAccess
    {
        private readonly HouseholdPartEntities _db;

        public HouseHoldPartAccess(HouseholdPartEntities db)
        {
            _db = db;
        }


        // Методы для работы с таблицей User

        public List<Suppliers> GetSuppliers()
        {
            var suppliers = _db.Suppliers.ToList();
            suppliers.Insert(0, new Suppliers { SupplierId = -1, NameSupplier = "Показать всё" });
            return suppliers;
        }

        public List<Facilities> GetFacilities()
        {
            var facilities = _db.Facilities.ToList();
            facilities.Insert(0, new Facilities { FacilitiesId = -1, NameFacilities = "Показать всё" });
            return facilities;
        }

        public List<Suppliers> GetSupplier()
        {
            return _db.Suppliers.ToList();
        }
        public List<Facilities> GetFacility()
        {
            return _db.Facilities.ToList();
        }
        public List<DocumentEmployee> GetDocuments()
        {
            return _db.DocumentEmployee.ToList();
        }
        public List<User> GetAllUsers()
        {
            return _db.User.ToList();
        }

        public User GetUserById(int id)
        {
            return _db.User.FirstOrDefault(u => u.UserId == id);
        }

        public void AddUser(User user)
        {
            _db.User.Add(user);
            _db.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            _db.Entry(user).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            User user = _db.User.Find(id);
            _db.User.Remove(user);
            _db.SaveChanges();
        }
        public List<Employee> GetEmployee()
        {
            return _db.Employee.ToList();
        }

        public void AddSuppliers(Suppliers suppliers)
        {
            _db.Suppliers.Add(suppliers);
            _db.SaveChanges();
        }
        public void AddScheduleEmployee(ScheduleEmployee schedule)
        {
            _db.ScheduleEmployee.Add(schedule);
            _db.SaveChanges();
        }
        public void AddEmployee(Employee employee)
        {
            _db.Employee.Add(employee);
            _db.SaveChanges();
        }
        public void AddFacilities(Facilities facilities)
        {
            _db.Facilities.Add(facilities);
            _db.SaveChanges();
        }
        public List<ScheduleEmployee> GetScheduleEmployee()
        {
            return _db.ScheduleEmployee.ToList();
        }
        public void RemoveScheduleEmployee(int ScheduleId)
        {
            var schedule = _db.ScheduleEmployee.Find(ScheduleId);
            if (schedule != null)
            {
                _db.ScheduleEmployee.Remove(schedule);
                _db.SaveChanges();
            }
        }

       
        public void RemoveEquipment(int EquipmentId)
        {
            var equipment = _db.Equipment.Find(EquipmentId);
            if (equipment !=null)
            {
                _db.Equipment.Remove(equipment);
                _db.SaveChanges();
            }
        }
        public void RemoveDocument(int DocumentId)
        {
            var document = _db.DocumentEmployee.Find(DocumentId);
            if (document != null)
            {
                _db.DocumentEmployee.Remove(document);
                _db.SaveChanges();
            }
        }
        public void AddDocuments(int documentId,int employeeId, string documentName, string documentsPath)
        {
            try
            {
                // Создаем новый объект DocumentEmployee
                var document = new DocumentEmployee
                {
                    DocumentId = documentId,
                    EmployeeId = employeeId,
                    DocumentName = documentName,
                    Documents = documentsPath
                };

                // Добавляем объект в контекст
                _db.DocumentEmployee.Add(document);

                // Сохраняем изменения в базе данных
                _db.SaveChanges();
            }
            catch {
                MessageBox.Show("Вы ввели уже имеющийся номер документа! Повторите попытку");
                return;
            }

        }
 
        public void RemoveFacilities(int facilityId)
        {
            var facility = _db.Facilities.Find(facilityId);
            if (facility != null)
            {
                var equipment = _db.Equipment.Where(d => d.IdFacilities == facilityId);
                _db.Equipment.RemoveRange(equipment);
                _db.Facilities.Remove(facility);
                _db.SaveChanges();
            }
        }
    public void RemoveEmployee(int EmployeeId)
        {
            var employee = _db.Employee.Find(EmployeeId);
            if (employee != null)
            {
                // Удаление связанных записей из таблицы DocumentEmployee
                var documents = _db.DocumentEmployee.Where(d => d.EmployeeId == EmployeeId);
                _db.DocumentEmployee.RemoveRange(documents);

                // Удаление связанных записей из таблицы ScheduleEmployee
                var schedules = _db.ScheduleEmployee.Where(s => s.IdEmployee == EmployeeId);
                _db.ScheduleEmployee.RemoveRange(schedules);

                // Удаление записи сотрудника
                _db.Employee.Remove(employee);
                _db.SaveChanges();
            }
    }
        public void RemoveSuppliers(int SupplierId)
        {
            var supplier = _db.Suppliers.Find(SupplierId);
            if (supplier != null)
            {
                var equipment = _db.Equipment.Where(d => d.IdSuppliers == SupplierId);
                _db.Equipment.RemoveRange(equipment);
                _db.Suppliers.Remove(supplier);
                _db.SaveChanges();
            }
        }
        public void UpdateScheduleEmployee(ScheduleEmployee schedule)
        {
            var dbSchedule = _db.ScheduleEmployee.Find(schedule.ScheduleId);
            if (dbSchedule != null)
            {
                dbSchedule.Date = schedule.Date;
                dbSchedule.TimeStart= schedule.TimeStart;
                dbSchedule.TimeEnd= schedule.TimeEnd;
                dbSchedule.IdEmployee = schedule.IdEmployee;
                _db.SaveChanges();
            }
        }

        public void UpdateSuppliers(Suppliers suppliers)
        {
            var dbSup = _db.Suppliers.Find(suppliers.SupplierId);
            if (dbSup != null) 
            { 
            dbSup.NameSupplier = suppliers.NameSupplier;
            dbSup.Contact = suppliers.Contact;
            dbSup.Comments= suppliers.Comments;
                _db.SaveChanges();
            }
        }
        public void UpdateFacilities(Facilities facility)
        {
            var dbFacilitiyes = _db.Facilities.Find(facility.FacilitiesId);
            if (dbFacilitiyes != null)
            {
                dbFacilitiyes.NameFacilities = facility.NameFacilities;
                _db.SaveChanges();
            }
        }
        public void UpdateDocuments(DocumentEmployee document)
        {
            var dbDocument = _db.DocumentEmployee.Find(document.DocumentId);
            if (dbDocument != null)
            {
                dbDocument.DocumentName = document.DocumentName;
                dbDocument.DocumentId = document.DocumentId;
                dbDocument.DocumentName = document.DocumentName;
                dbDocument.EmployeeId = document.EmployeeId;
                dbDocument.Documents = document.Documents;
                document.Path = "Documents/" + System.IO.Path.GetFileName(document.Path);
                _db.SaveChanges();
            }
        }
       
        public List<Post> GetPost()
        {
            return _db.Post.ToList();
        }
        public List<Employee> GetEmployeesByPost(int idPost)
        {
            return _db.Employee.Where(e => e.IdPost == idPost).ToList();
        }


        public void UpdateEquipment(Equipment equipment)
        {
            var dbEq = _db.Equipment.Find(equipment.EquipmentId);
            if (dbEq != null)
            {
                dbEq.NameEquipment = equipment.NameEquipment;
                dbEq.PurchaseDate = equipment.PurchaseDate;
                dbEq.Cost= equipment.Cost;
                dbEq.Count= equipment.Count;
                dbEq.IdFacilities = equipment.IdFacilities;
                dbEq.IdSuppliers= equipment.IdSuppliers;
                _db.SaveChanges();
            }
        }

        public void UpdateEmployee(Employee employee)
        {
            var dbEmployee = _db.Employee.Find(employee.EmployeeId);
            if (dbEmployee != null)
            {
                dbEmployee.NameEmployee = employee.NameEmployee;
                dbEmployee.SurnameEmployee = employee.SurnameEmployee;
                dbEmployee.SerialPasportEmployee = employee.SerialPasportEmployee;
                dbEmployee.NumberPasportEmployee = employee.NumberPasportEmployee;
                dbEmployee.Address = employee.Address;
                dbEmployee.IdPost = employee.IdPost;
                dbEmployee.Contact = employee.Contact;
                _db.SaveChanges();
            }
            
            
        }

        public void DeleteEmployee(int id)
        {
            Employee employee = _db.Employee.Find(id);
            _db.Employee.Remove(employee);
            _db.SaveChanges();
        }


        public List<Equipment> GetAllEquipment()
        {
            return _db.Equipment.ToList();
        }

        public List<Equipment> GetEquipmentByFacilities(int idFacilities)
        {
            return _db.Equipment.Where(e => e.IdFacilities == idFacilities).ToList();
        }

        public void AddEquipment(Equipment equipment)
        {
            _db.Equipment.Add(equipment);
            _db.SaveChanges();
        }

   

        public void DeleteEquipment(int id)
        {
            Equipment equipment = _db.Equipment.Find(id);
            _db.Equipment.Remove(equipment);
            _db.SaveChanges();
        }
    }

}