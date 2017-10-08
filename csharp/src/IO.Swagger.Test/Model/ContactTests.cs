/* 
 * API Cadastro
 *
 * Teste para workflow API-based:   - Restlet gera API e exporta swagger.json   - SwaggerHub importa arquivo e gera server stub   - Instala server stub em docker repo: io.swagger   - Compila em máquina x64 e gera linux-arm: io.swagger   - Docker push josemottalopes/io.swagger   - Na Raspberry Pi, com hostname \"pi\", instala-se o Docker   - Docker run -d josemottalopes/io.swagger   - Retorna à maquina x64 e acessa o pi-server-stub via browser   - http://pi:5000/swagger/ui/index.html    
 *
 * OpenAPI spec version: 1.2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;
using System.Reflection;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing Contact
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ContactTests
    {
        // TODO uncomment below to declare an instance variable for Contact
        //private Contact instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Contact
            //instance = new Contact();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Contact
        /// </summary>
        [Test]
        public void ContactInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Contact
            //Assert.IsInstanceOfType<Contact> (instance, "variable 'instance' is a Contact");
        }

        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'FirstName'
        /// </summary>
        [Test]
        public void FirstNameTest()
        {
            // TODO unit test for the property 'FirstName'
        }
        /// <summary>
        /// Test the property 'LastName'
        /// </summary>
        [Test]
        public void LastNameTest()
        {
            // TODO unit test for the property 'LastName'
        }
        /// <summary>
        /// Test the property 'TaxId'
        /// </summary>
        [Test]
        public void TaxIdTest()
        {
            // TODO unit test for the property 'TaxId'
        }
        /// <summary>
        /// Test the property 'Birthday'
        /// </summary>
        [Test]
        public void BirthdayTest()
        {
            // TODO unit test for the property 'Birthday'
        }
        /// <summary>
        /// Test the property 'Active'
        /// </summary>
        [Test]
        public void ActiveTest()
        {
            // TODO unit test for the property 'Active'
        }
        /// <summary>
        /// Test the property 'Rank'
        /// </summary>
        [Test]
        public void RankTest()
        {
            // TODO unit test for the property 'Rank'
        }
        /// <summary>
        /// Test the property 'Company'
        /// </summary>
        [Test]
        public void CompanyTest()
        {
            // TODO unit test for the property 'Company'
        }

    }

}
