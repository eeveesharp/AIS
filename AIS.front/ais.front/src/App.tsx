import React from 'react';
import { Provider } from 'react-redux';
import { Route, Routes } from 'react-router-dom';
import Header from './core/components/header/Header';
import { store } from './core/store/index';
import MainRoutes from './core/constants/mainRoutes';
import Sessions from './pages/session/Session';
import QuestionsSets from './pages/questionsSets/QuestionsSets';
import QuestionSetDescription from './pages/questionSetDescription/QuestionSetDescription';
import QuestionAreaForm from './pages/questionAreaForm/QuestionAreaForm';
import AddQuestionSet from './pages/questionSetAdd/QuestionSetAdd';
import QuestionAreas from './pages/questionAreas/QuestionAreas';
import QuestionAreaDescription from './pages/questionAreaDescription/QuestionAreaDescription';
import Questions from './pages/questions/Questions';

const App: React.FC = () => (
  <Provider store={store}>
    <Header />
    <Routes>
      <Route path={MainRoutes.questionAreas} element={<QuestionAreas />} />
      <Route path={MainRoutes.sessions} element={<Sessions />} />
      <Route path={MainRoutes.questionSets} element={<QuestionsSets />} />
      <Route path={`${MainRoutes.questionSet}/:id`} element={<QuestionSetDescription />} />
      <Route path={`${MainRoutes.questionArea}/:id`} element={<QuestionAreaDescription />} />
      <Route path={`${MainRoutes.questionAreaForm}/:id`} element={<QuestionAreaForm />} />
      <Route path={MainRoutes.questionAreaForm} element={<QuestionAreaForm />} />
      <Route path={MainRoutes.addQuestionSet} element={<AddQuestionSet />} />
      <Route path={MainRoutes.questions} element={<Questions />} />
    </Routes>
  </Provider>
);

export default App;
